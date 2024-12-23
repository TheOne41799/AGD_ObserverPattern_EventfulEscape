using System;

public class EventController
{
    public Action BaseEvent;

    public void AddListner(Action listener) => BaseEvent += listener;
    public void RemoveListner(Action listener) => BaseEvent -= listener;
    public void InvokeEvent() => BaseEvent?.Invoke();
}
