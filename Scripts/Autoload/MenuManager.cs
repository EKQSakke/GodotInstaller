
internal partial class MenuManager : Node
{
    public override void _Ready()
    {
        FetchData();
        CreateLayout();
    }

    private void CreateLayout()
    {
       var container = this.AddChildOfType<CenterContainer>();
       container.AnchorsPreset = 8;
       var vBox = container.AddChildOfType<VBoxContainer>();
       var text = vBox.AddChildOfType<Label>();
       text.Text = "Yolo";
    }

    private static void FetchData()
    {
        GD.Print($"Get data");
    }
}