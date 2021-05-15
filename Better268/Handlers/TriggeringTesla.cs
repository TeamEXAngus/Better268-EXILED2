using Exiled.Events.EventArgs;

namespace Better268.Handlers
{
    internal class TriggeringTesla
    {
        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            if (ev.Player.GetEffectActive<CustomPlayerEffects.Scp268>())
            {
                ev.IsTriggerable = false;
            }
        }
    }
}