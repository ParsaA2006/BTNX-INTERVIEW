using BTNXProfileApp.Models;

namespace BTNXProfileApp.Services;

public class ProfileService
{
    private Profile _currentProfile = new Profile
    {
        Id = 1,
        FirstName = "John",
        LastName = "Doe",
        Email = "john.doe@example.com",
        PhoneNumber = "123-456-7890"
    };

    public Profile GetProfile()
    {
        return _currentProfile;
    }

    public void UpdateProfile(Profile profile)
    {
        _currentProfile = profile;
    }
} 