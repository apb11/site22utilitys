using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Roles;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Scp096;
using PlayerRoles;
using HintServiceMeow;
using HintServiceMeow.Core.Enum;
using HintServiceMeow.Core.Models.Hints;
using PlaceholderAPI.Placeholders;




namespace site22utillitys;

[CustomRole(RoleTypeId.None)]
public class FreeCustomRole1 : CustomRole, ICustomRole
{
    public int Chance { get; set; } = 0;
    public override uint Id { get; set; } = 103;
    public override RoleTypeId Role { get; set; } = RoleTypeId.None;
    public override int MaxHealth { get; set; } = 2450;
    public override string Name { get; set; } = "RP096";
    public override string Description { get; set; } = "096 for RPs";
    public override string CustomInfo { get; set; } = "SCP-096";
    public Scp096Role Enraged { get; private set; }

    public void Enrage(EnragingEventArgs ev)
    {
        if (ev.Scp096 != Enraged)
        {
            ev.Scp096.EnragedTimeLeft = float.MaxValue;


            Hint hint = new Hint
            {
                Text = "targets: %targetamount% ",
                FontSize = 40,
                YCoordinate = 25,
                Alignment = HintAlignment.Left
            };





        }


    }




}