namespace JOGUnit;

public class Measurement
{
    public string? MeasurementType { get; set; }
    public Unit? BaseUnit { get; set; }
    public List<Unit> Units { get; init; } = new List<Unit>();
}