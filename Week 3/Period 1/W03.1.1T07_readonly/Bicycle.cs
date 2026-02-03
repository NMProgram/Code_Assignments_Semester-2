class Bicycle
{
    public string OwnerName;
    public readonly string FrameNumber;
    public string PaintColor;
    public int CurrentGear = 1;

    public Bicycle(string ownerName, string frameNumber, string paintColor)
    {
        OwnerName = ownerName;
        FrameNumber = frameNumber;
        PaintColor = paintColor;
    }

    public void ChangeOwner(string ownerName) => OwnerName = ownerName;
    public void ChangePaintColor(string paintColor) => PaintColor = paintColor;
    public void ChangeGear(int gear) => CurrentGear = gear;
}
