public sealed record DemoEvent(string Name, string? Actor, string? Detail);

public static class EventRedaction
{
    public static DemoEvent SafeForDisplay(DemoEvent value) =>
        value with { Actor = value.Actor is null ? null : "[redacted]", Detail = null };
}
