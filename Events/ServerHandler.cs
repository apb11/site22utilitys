namespace site22utillitys.Events;

public class ServerHandler
{
    public void OnReloadingConfigs()
    {
        site22utillitys.Config.LoadItems();
    }
}
