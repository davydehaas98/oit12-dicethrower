String message = "";

void Communication()
{
  while (Serial.available() > 0)
  {
    char readChar = (char)Serial.read();
    switch (readChar)
    {
      case '#':
        message = "";
        break;
      case '%':
        ReadMessage();
        message = "";
        break;
      default:
        message += readChar;
        break;
    }
  }
}

void ReadMessage()
{
  int mdie = message.substring(message.indexOf("d") + 1).toInt();
  int mthrows = message.substring(message.indexOf(":") + 1).toInt();
  if (message.indexOf("adv") > 0)
  {
    ThrowAdv(mdie);
  }
  else if (message.indexOf("dis") > 0)
  {
    ThrowDis(mdie);
  }
  else
  {
    Throw(mdie, mthrows);
  }
  message = "";
}
