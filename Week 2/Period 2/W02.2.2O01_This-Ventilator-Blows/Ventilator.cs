class Ventilator
{
    public int Speed = 0;
    public List<Button> Buttons = [
        new Button(), new Button(), new Button(), new Button()
    ];

    public Ventilator() { }

    public void PressButton(int number)
    {
        if (Buttons.Count <= number || number < 0) { return; }
        for (int i = 0; i < Buttons.Count; i++)
        {
            Buttons[number].IsPressed = number != i || number == 0;
        }
        Speed = number;
    }

    public string Blow() => Speed switch
    {
        <= 0 => "Off",
           1 => "~~~",
           2 => "^^^",
        >= 3 => "===",
    };
}
