using System;

internal partial class MenuManager : Node
{
    public override void _Ready()
    {
        FetchData();
        CreateLayout();
    }

    private static void CreateLayout()
    {
         
    }

    private static void FetchData()
    {
        GD.Print($"Get data");
    }
}