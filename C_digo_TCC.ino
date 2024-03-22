//SMARQ - CÓDIGO ARDUINO

String data;
char d1;

//Variáveis
int luz;
float temp = 0.0;


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
        
        temp = analogRead(A3) * 5 / 1024;
        temp = temp / 0.01;
        if (temp >= 30) {
          tone(8, 300);
          delay(500);
          noTone(8);
        } else { //temp1 < 30
          noTone(8);
        }
        break;

      case 'H':
        
        temp = analogRead(A4) * 5 / 1024;
        temp = temp / 0.01;
        if (temp >= 30) {
          tone(9, 300);
          delay(500);
          noTone(9);
        } else { //temp < 30
          noTone(9);
        }
        break;

      case 'I':
       
        temp = analogRead(A5) * 5 / 1024;
        temp = temp / 0.01;
        if (temp >= 30) {
          tone(10, 300);
          delay(500);
          noTone(10);
        } else { //temp < 30
          noTone(10);
        }
        break;

      case 'Z':
      digitalWrite(2, LOW);
      digitalWrite(3, LOW);
      digitalWrite(4, LOW);
    }
  }
}
