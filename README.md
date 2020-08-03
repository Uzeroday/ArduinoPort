# ArduinoPort

เชื่อมต่อ SerialPort Arduino กับ c# 

Arduino Code - uno R3

void setup() { 
  Serial.begin(9600);
}   
void loop() 
{ 
   if(Serial.available() > 0)  
    { 
      String Read = Serial.readString();
      Serial.println(Read);
      if(Read ==  "i here")
      {
         Serial.println("I");
      }
      else if(Read ==  "o")
      {
          Serial.println("Ohhhh");
      }
    }
}
