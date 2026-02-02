class Button
{
    public bool IsPressed;
    public int TimesPressed;
    public Button(bool isPressed = false, int timesPressed = 0)
    {
        IsPressed = isPressed;
        TimesPressed = timesPressed;
    }
    public void Press()
    {
        IsPressed = IsPressed ? false : true;
        TimesPressed++;
    }
    public string Info()
    {
        string msg1 = IsPressed ? "Button is pressed." : "Button is not pressed.";
        string msg2 = $"Pressed {TimesPressed} times.";
        return $"{msg1}\n{msg2}";
    }
}
