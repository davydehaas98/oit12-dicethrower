#include <LiquidCrystal.h>

LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
const int potdie = A0;
const int potthrow = A1;
const int potadv = A2;
const int button = 7;
const int buzzer = 9;

int Dice[] = {2, 3, 4, 6, 8, 10, 12, 20, 100};
bool buttonpressed = false;

void setup() {
  Serial.begin(9600);
  pinMode(button, INPUT);
  pinMode(buzzer, OUTPUT);
  randomSeed(analogRead(5));

  lcd.begin(16, 2);
}

void loop() {
  int die = Dice[map(analogRead(potdie), 0, 1023, 0, 8)];
  int throws = map(analogRead(potthrow), 0, 1023, 1, 30);
  int mode = map(analogRead(potadv), 0, 1023, 0, 3);
  Communication();

  lcd.setCursor(0, 0);
  lcd.print("d");
  lcd.print(die);
  lcd.print(" ");
  switch (mode)
  {
    case 1:
      lcd.print(throws);
      lcd.print(" throws  ");
      lcd.setCursor(13, 1);
      lcd.print("   ");
      break;
    case 0:
      lcd.print("          ");
      lcd.setCursor(13, 1);
      lcd.print("adv");
      break;
    case 2:
      lcd.print("          ");
      lcd.setCursor(13, 1);
      lcd.print("dis");
      break;
  }
  if (digitalRead(button) == HIGH && buttonpressed == false)
  {
    delay(50);
    buttonpressed = true;
  }
  else if (digitalRead(button) == LOW && buttonpressed == true)
  {
    buttonpressed = false;
    switch (mode)
    {
      case 0:
        ThrowAdv(die);
        break;
      case 1:
        Throw(die, throws);
        break;
      default:
        ThrowDis(die);
        break;
    }
  }
}
