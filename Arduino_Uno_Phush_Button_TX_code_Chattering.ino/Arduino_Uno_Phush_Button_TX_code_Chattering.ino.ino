/*
 재작자: 여상준(Yeo Sang-Jun)
 Blog: https://blog.naver.com/yeosj116/221129859201
 아두이노 소스코드 공개 버전
 */

//---User arbitrary setting possible---//
const int Apin = 13; //Button 1
const int Bpin = 12; //Button 2
const int Cpin = 11; //Button 3
const int Dpin = 10; //Button 4
const int Epin = 9; //Button 5
const int plus = 8; //Button power supply pin
const int chattering = 0; //Wait for chattering to stop for ms seconds. Normally set to 5ms or 10ms.


//---User arbitrary setting impossible---//
int a,b,c,d,e = 0; //Inspection only (Do not modify)
int A,B,C,D,E = 0; //Inspection only (Do not modify)

void setup() {
  pinMode(Apin,INPUT_PULLUP);
  pinMode(Bpin,INPUT_PULLUP);
  pinMode(Cpin,INPUT_PULLUP);
  pinMode(Dpin,INPUT_PULLUP);
  pinMode(Epin,INPUT_PULLUP);
  pinMode(plus, OUTPUT);
  Serial.begin(9600); //Do not modify communication speed
}
void loop() {
  if(digitalRead(Apin)==LOW){
        if(A==0){Serial.println("A"); a=0; A=1; delay(chattering);}
     }else if(a==0) {Serial.println("1"); a=1; A=0; delay(chattering);}
     
  if(digitalRead(Bpin)==LOW){
        if(B==0){Serial.println("B"); b=0; B=1; delay(chattering);}
     }else if(b==0) {Serial.println("2"); b=1; B=0; delay(chattering);}
     
  if(digitalRead(Cpin)==LOW){
       if(C==0){Serial.println("C"); c=0; C=1; delay(chattering);}
     }else if(c==0) {Serial.println("3"); c=1; C=0; delay(chattering);}
     
  if(digitalRead(Dpin)==LOW){
        if(D==0){Serial.println("D"); d=0; D=1; delay(chattering);}
     }else if(d==0) {Serial.println("4"); d=1; D=0; delay(chattering);}
     
  if(digitalRead(Epin)==LOW){
        if(E==0){Serial.println("E"); e=0; E=1; delay(chattering);}
     }else if(e==0) {Serial.println("5"); e=1; E=0; delay(chattering);}
     Serial.flush(); //Removing this code will also work.
}
