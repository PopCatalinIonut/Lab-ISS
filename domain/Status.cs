namespace domain
{
    public enum Status
    {
        [LinqToDB.Mapping.MapValue(Value = "Resolved")]
        Resolved,
        [LinqToDB.Mapping.MapValue(Value = "Unresolved")]
        Unresolved,
        [LinqToDB.Mapping.MapValue(Value = "WorkingOn")]
        WorkingOn
    }
}