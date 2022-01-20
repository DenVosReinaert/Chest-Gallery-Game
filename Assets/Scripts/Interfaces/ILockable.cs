public interface ILockable
{
    public bool locked { get; set; }
    public int lockCount { get; set; }
}
