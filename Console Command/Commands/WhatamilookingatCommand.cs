namespace ExampleExpansion.Commands;


internal class WhatamilookingatCommand : SR2ECommand
{
    public override string ID => "waila";
    public override string Usage => "waila";
    // Specify the command type, you can also specify multiple categories
    public override CommandType type => CommandType.Miscellaneous;

    public override bool Execute(string[] args)
    {
        if (!args.IsBetween(0,0)) return SendNoArguments();

        // This command only works in a save
        if (!inGame) return SendLoadASaveFirst();
        
        // Get camera and send a no camera mesage otherwise
        var cam = MiscEUtil.GetActiveCamera(); 
        if (cam == null) return SendNoCamera();
        
        // You can use the defaultMask from MiscEUtil for Raycasts
        if (Physics.Raycast(new Ray(cam.transform.position, cam.transform.forward), out var hit,Mathf.Infinity,MiscEUtil.defaultMask))
        {
            var obj = hit.collider.gameObject;
            SendMessage($"You are looking at {obj.name}");
            
            //Return true if the command was a success
            return true;
        }
        return SendNotLookingAtAnything();
    }
}