void Throw(int die, int throws)
{
  int total = 0;
  Serial.print("#d");
  Serial.print(die);
  Serial.print("%#throws");
  Serial.print(throws);
  Serial.print("%");
  for (int i = 0; i < throws; i++)
  {
    int rn = random(1, die + 1);
    Serial.print("#rn");
    Serial.print(rn);
    Serial.print("%");
    if (die == 20 && throws == 1 && rn == 20)
    {
      tone(buzzer, 1000);
      delay(200);
      noTone(buzzer);
    }
    else if (die == 20 && throws == 1 && rn == 1)
    {
      tone(buzzer, 100);
      delay(200);
      noTone(buzzer);
    }
    total += rn;
  }
  Serial.print("#total");
  Serial.print(total);
  Serial.println("%");
  lcd.setCursor(0, 1);
  lcd.print("Total: ");
  lcd.print(total);
  lcd.print("   ");
}

void ThrowAdv(int die)
{
  int rn1 = random(1, die + 1);
  delay(random(1, 50));
  int rn2 = random(1, die + 1);

  Serial.print("#d");
  Serial.print(die);
  Serial.print("%#rn");

  if (die == 20 && rn1 == 20 || die == 20 && rn2 == 20)
  {
    tone(buzzer, 1000);
    delay(200);
    noTone(buzzer);
  }

  lcd.setCursor(0, 1);
  lcd.print("Thrown: ");
  if (rn1 < rn2)
  {
    Serial.print(rn2);
    lcd.print(rn2);
    lcd.print("  ");
    if (die == 20 && rn2 == 1)
    {
      tone(buzzer, 100);
      delay(200);
      noTone(buzzer);
    }
  }
  else
  {
    Serial.print(rn1);
    lcd.print(rn1);
    lcd.print("  ");
    if (die == 20 && rn1 == 1)
    {
      tone(buzzer, 100);
      delay(200);
      noTone(buzzer);
    }
  }
  Serial.println("%#adv%");
}
void ThrowDis(int die)
{
  int rn1 = random(1, die + 1);
  delay(50);
  int rn2 = random(1, die + 1);
  Serial.print("#d");
  Serial.print(die);
  Serial.print("%#rn");

  if (die == 20 && rn1 == 1 || die == 20 && rn2 == 1)
  {
    tone(buzzer, 100);
    delay(200);
    noTone(buzzer);
  }

  lcd.setCursor(0, 1);
  lcd.print("Thrown: ");
  if (rn1 > rn2)
  {
    Serial.print(rn2);
    lcd.print(rn2);
    lcd.print("  ");
    if (rn2 == 20)
    {
      tone(buzzer, 1000);
      delay(200);
      noTone(buzzer);
    }
  }
  else
  {
    Serial.print(rn1);
    lcd.print(rn1);
    lcd.print("  ");
    if (rn1 == 20)
    {
      tone(buzzer, 1000);
      delay(200);
      noTone(buzzer);
    }
  }
  Serial.println("%#dis%");
}
