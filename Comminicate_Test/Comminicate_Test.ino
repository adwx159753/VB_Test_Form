/*----------------------------------------------------------------------------*/
/*------------------------------ [Define Field] ------------------------------*/
/*----------------------------------------------------------------------------*/
// #include <cstdint>
#define CHECKCODE1 12
#define CHECKCODE2 34
#define CHECKCODE3 56
#define VER_MAJOR 0x01
#define VER_MINOR 0x00
#define VER_BUILD 0x00
/* --- define field end --- */

/*----------------------------------------------------------------------------*/
/*----------------------------- [Variable Field] -----------------------------*/
/*----------------------------------------------------------------------------*/
typedef enum {
  GET_DATA_INITIAL            = 0x00,
  GET_DATA_CHECKCODE1         = 0x01,
  GET_DATA_CHECKCODE2         = 0x02,
  GET_DATA_CHECKCODE3         = 0x03,
  GET_DATA_ID                 = 0x04,
  GET_DATA_LEN                = 0x05,
  GET_DATA_DATA               = 0x06,
  GET_DATA_OK                 = 0x07,
  GET_DATA_CHECKSUM_ERROR     = 0x08,
  GET_DATA_CHECKCODE_ERROR    = 0x09
} GET_DATA_STATUS;

typedef struct {
  uint8_t Index;
  uint8_t Step;
  uint8_t ID;
  uint8_t LEN;
  uint8_t Data[256];
  uint8_t checksum;
  GET_DATA_STATUS status;
} UART_DATA;

UART_DATA RxData;

/* [2025/05/06] Andrew */
enum HP_Output_Level_Control
{
	LV0 = 0b0000,
	LV1 = 0b0001,
	LV2 = 0b0010,
	LV3 = 0b0011,
	LV4 = 0b0100,
	LV5 = 0b0101,
	LV6 = 0b0110,
	LV7 = 0b0111,
	LV8 = 0b1000,
	LV9 = 0b1001,
};

enum HP_Mute
{
	Is_muted = 0b0, 				/* 0: HPLOUT is muted */
	Is_not_muted = 0b1,				/* 1: HPLOUT is not muted */
};

enum HP_Power_Down_Drive_Control
{
	Weakly_driven = 0b0,			/* 0: HPLOUT is weakly driven to a common-mode when powered down */
	High_impedance = 0b1,			/* 1: HPLOUT is high-impedance when powered down */
};

enum HP_Volume_Control_Status 
{
	All_been_applied = 0b0, 		/* 0: All programmed gains to HPLOUT have been applied */
	Not_all_been_applied = 0b1, 	/* 1: Not all programmed gains to HPLOUT have been applied yet */
};


enum HP_Power_Control
{
	Not_fully_powered_up = 0b0, 	/* 0: HPLOUT is not fully powered up */
	Is_fully_powered_up = 0b1,		/* 1: HPLOUT is fully powered up */
};


enum LOPM_Output_Level_Control
{
	LV0 = 0b0000,
	LV1 = 0b0001,
	LV2 = 0b0010,
	LV3 = 0b0011,
	LV4 = 0b0100,
	LV5 = 0b0101,
	LV6 = 0b0110,
	LV7 = 0b0111,
	LV8 = 0b1000,
	LV9 = 0b1001,
};

enum LOPM_Mute
{
	Is_muted = 0b0, 				/* 0: HPLOUT is muted */
	Is_not_muted = 0b1,				/* 1: HPLOUT is not muted */
};

enum LOPM_Volume_Control_Status 
{
	All_been_applied = 0b0, 		/* 0: All programmed gains to HPLOUT have been applied */
	Not_all_been_applied = 0b1, 	/* 1: Not all programmed gains to HPLOUT have been applied yet */
};

enum LOPM_Power_Status
{
	Not_fully_powered_up = 0b0, 	/* 0: HPLOUT is not fully powered up */
	Is_fully_powered_up = 0b1,		/* 1: HPLOUT is fully powered up */
};

typedef union
{
	uint8_t byt;
	typedef struct
	{
		HP_Output_Level_Control D7_D4:4;
		HP_Mute D3:1;
		HP_Power_Down_Drive_Control D2:1;
		HP_Volume_Control_Status D1:1;
		HP_Power_Control D0:1;
	}bits;
} HP_output_level_control_register;

typedef union
{	
	uint8_t byt;
	typedef struct
	{
		LOPM_Output_Level_Control D7_D4:4;
		LOPM_Mute D3:1;
		uint8_t Reserved:1;
		LOPM_Volume_Control_Status D1:1;
		LOPM_Power_Status D0:1;
	}bits;
} LOPM_output_level_control_register;

typedef struct
{
	HP_output_level_control_register HP[2];		// R51, R65
	LOPM_output_level_control_register LOP[2];	// R86, R93
} Output_level_control_register;


Output_level_control_register reg;
/* --- Variable field end --- */

/*----------------------------------------------------------------------------*/
/*------------------------------ [Initial Field] -----------------------------*/
/*----------------------------------------------------------------------------*/
void UART_DATAInit(UART_DATA& uart)
{
  uart.Index = 0U;
  uart.Step = 0U;
  uart.ID = 0U;
  uart.LEN = 0U;
  for (int i = 0; i < 256; i++) {
    uart.Data[i] = 0;
  }
  uart.checksum = 0U;
  uart.status = GET_DATA_INITIAL;
}
/* --- Initial field end --- */


/*----------------------------------------------------------------------------*/
/*----------------------------- [Get Data Field] -----------------------------*/
/*----------------------------------------------------------------------------*/
void Serial3GetData()
{
  if (Serial3.available() > 0) {
    uint8_t str = Serial3.read();
    Serial.println((uint8_t)str);
    if (DataCheck(str)) {
      /* Data correct, do something! */
      CmdProcess();
    }
  }
}

bool DataCheck(uint8_t str)
{
  bool state = false;
  switch (RxData.Step) {
    case 0:
      if (str == CHECKCODE1) {
        RxData.Step++;
        RxData.status = GET_DATA_CHECKCODE1;
      }
      else {
        RxData.Step = 0;
        RxData.status = GET_DATA_CHECKCODE_ERROR;
        Serial.println("GET_DATA_CHECKCODE_ERROR");
      }
      break;
    case 1:
      if (str == CHECKCODE2) {
        RxData.Step++;
        RxData.status = GET_DATA_CHECKCODE2;
      }
      else {
        RxData.Step = 0;
        RxData.status = GET_DATA_CHECKCODE_ERROR;
        Serial.println("GET_DATA_CHECKCODE_ERROR");
      }
      break;
    case 2:
      if (str == CHECKCODE3) {
        RxData.Step++;
        RxData.status = GET_DATA_CHECKCODE3;
      }
      else {
        RxData.Step = 0;
        RxData.status = GET_DATA_CHECKCODE_ERROR;
        Serial.println("GET_DATA_CHECKCODE_ERROR");
      }
      break;
    case 3:
      RxData.ID = str;
      RxData.Step++;
      RxData.checksum += str;
      RxData.status = GET_DATA_ID;
      break;
    case 4:
      RxData.LEN = str;
      if(RxData.LEN == 0) RxData.Step++; // skip DATA field
      RxData.Step++;
      RxData.checksum += str;
      RxData.status = GET_DATA_LEN;
      break;
    case 5:
      if (RxData.Index < RxData.LEN) {
        RxData.Data[RxData.Index++] = str;
        RxData.checksum += str;
      } 
      if(RxData.Index >= RxData.LEN) {
        RxData.Step++;
      }
      RxData.status = GET_DATA_DATA;
      break;
    case 6:
      if (str != RxData.checksum) {
        UART_DATAInit(RxData);
        RxData.status = GET_DATA_CHECKSUM_ERROR;
        Serial.println("GET_DATA_CHECKSUM_ERROR");
      }
      else {
        RxData.status = GET_DATA_OK;
        RxData.Index = 0;
        RxData.Step = 0;
        RxData.checksum = 0;
        state = true;
      }
      break;
    default:
      break;
  }
  return state;
}
/*  --- Get Data Field end ---  */


/*----------------------------------------------------------------------------*/
/*---------------------------- [Send Data Field] -----------------------------*/
/*----------------------------------------------------------------------------*/
void Serial3SendData(UART_DATA& TxData) {
  Serial3.write(CHECKCODE1);
  Serial3.write(CHECKCODE2);
  Serial3.write(CHECKCODE3);
  Serial3.write(TxData.ID);
  Serial3.write(TxData.LEN);
  for(int i = 0; i < TxData.LEN; i++) {
    Serial3.write(TxData.Data[i]);
  }
  Serial3.write(TxData.checksum);
}
/*  --- Send Data Field end ---  */

/*----------------------------------------------------------------------------*/
/*--------------------------- [CMD Process Field] ----------------------------*/
/*----------------------------------------------------------------------------*/
void CmdProcess() {
  switch (RxData.ID) {
    case 0:
      /* case 0, do something */
      SendVersion();
      break;
      
    case 1:
      /* case 1, do something */
      break;
      
    case 2:
      /* case 2, do something */
      break;
      
    default:
      /* default, do nothing */
      break;
  }
}

/**
 * Sending the current version of Arduino.
 */
void SendVersion() {
  UART_DATA TxData;
  UART_DATAInit(TxData);
  TxData.ID = 0;
  TxData.LEN = 3;
  TxData.Data[0] = VER_MAJOR;
  TxData.Data[1] = VER_MINOR;
  TxData.Data[2] = VER_BUILD;
  calChecksum(TxData);
  Serial3SendData(TxData);
}

void calChecksum(UART_DATA& TxData) {
  TxData.checksum += TxData.ID;
  TxData.checksum += TxData.LEN;
  for(int i = 0; i < TxData.LEN; i++) {
    TxData.checksum += TxData.Data[i];
  }
}
/*  --- CMD Process Field end ---  */

void setup()
{
  Serial.begin(115200);
  Serial1.begin(115200);
  Serial2.begin(115200);
  Serial3.begin(115200);
  UART_DATAInit(RxData);
  Serial.println("Initial Complete!");
}

void loop()
{
  Serial3GetData();
}
