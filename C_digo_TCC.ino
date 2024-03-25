//SMARQ - CÓDIGO ARDUINO

String data;
char d1;

//Variáveis
int luz;
float temp;


void setup() {
  Serial.begin(9600);
  //Led's e Buzzer's estão no modo saída(OUTPUT)
  pinMode(2, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT); //Buzzer
  pinMode(11, OUTPUT); //Buzzer
  pinMode(12, OUTPUT); //Buzzer
}

void loop() {
  //Code we need to Decode the String and turn the led on and off
  if (Serial.available()) {
    data = Serial.readString();
    d1 = data.charAt(0);
    switch (d1) {           //select action based upon first character

      //Função: Ligar Led 2
      case 'A':             //first character is an A = turn on pin 2
        digitalWrite(2, HIGH);
        break;

      //Função: Ligar Led 3
      case 'B':
        digitalWrite(3, HIGH);
        break;

      //Função: Ligar Led 4
      case 'C':
        digitalWrite(4, HIGH);
        break;


      //Função: Interação LDR e Led
      case 'D':
        luz = analogRead(A0);
        if (luz < 100) {
          digitalWrite(5 , HIGH);
        } else { //luz > 100
          digitalWrite(5 , LOW);
        }
        delay(1000);
        break;

      case 'E':
        luz = analogRead(A1);
        if (luz < 100) {
          digitalWrite(6 , HIGH);
        } else { //luz2 > 100
          digitalWrite(6 , LOW);
        }
        break;

      case 'F':
        luz = analogRead(A2);
        if (luz < 100) {
          digitalWrite(7, HIGH);
        } else { //luz3 < 100
          digitalWrite(7, LOW);
        }
        break;


      case 'G':        
        temp = (float(analogRead(A3))*5/(1023))/0.01;
        if (temp >= 30) {
          digitalWrite(8, HIGH);
          //tone(8, 300);
          //delay(500);
          //noTone(8);
        } else { //temp1 < 30
          
          //noTone(8);
        }
        break;

      case 'H':
        temp = (float(analogRead(A4))*5/(1023))/0.01;
        temp = temp / 0.01;
        if (temp >= 30) {
          digitalWrite(9, HIGH);
          //tone(9, 300);
          //delay(500);
          //noTone(9);
        } else { //temp < 30
          //noTone(9);
          digitalWrite(9, LOW);
        }
        break;

      case 'I':
        temp = (float(analogRead(A5))*5/(1023))/0.01;
        temp = temp / 0.01;
        if (temp >= 30) {
          digitalWrite(10, HIGH);
          //tone(10, 300);
          //delay(500);
          //noTone(10);
        } else { //temp < 30
          //noTone(10);
          digitalWrite(10, LOW);
        }
        break;


      case 'Z':
      digitalWrite(2, LOW);
      digitalWrite(3, LOW);
      digitalWrite(4, LOW);
      digitalWrite(5, LOW);
      digitalWrite(6, LOW);
      digitalWrite(7, LOW);
      digitalWrite(8, LOW);
      digitalWrite(9, LOW);
      digitalWrite(10, LOW);
      //noTone(8);
      //noTone(9);
      //noTone(10);
    }
  }
}
