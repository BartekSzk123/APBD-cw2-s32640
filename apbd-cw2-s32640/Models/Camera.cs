namespace apbd_cw2_s32640;

public class Camera(string name, int resolution, bool hasFlash) : Equipment(name)
{
    public bool HasFlash { get; } = hasFlash;
    public int Resolution { get; } = resolution;
}