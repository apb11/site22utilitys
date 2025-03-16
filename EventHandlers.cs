using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Scp096;
using System;

namespace site22utillitys;

public class EventHandlers
{
    public void OnPlayerVerified(VerifiedEventArgs ev)
    {
        try
        {
            Log.Info($"Player {ev.Player.Nickname} (UserId: {ev.Player.UserId}) has been verified.");
        }
        catch (Exception ex)
        {
            Log.Error($"An error occurred in OnPlayerVerified: {ex}");
        }


        
    }

    




}