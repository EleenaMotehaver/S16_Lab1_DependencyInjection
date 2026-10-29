namespace ZombieParty.Utility
{
    public interface IImageFileManager1
    {
        string? UploadImage(IFormCollection form, bool edit, string? oldImagePath = null);
    }
}