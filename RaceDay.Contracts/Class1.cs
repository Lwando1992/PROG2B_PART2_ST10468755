namespace RaceDay.Contracts
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class RegisterRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public class AuthResponse { }
    public class ProfileDto { }
    public class UpdateProfileRequest { }
    public class CreateEventRequest { }
    public class UpdateEventRequest { }
    public class EventDto { }
    public class CreateCategoryRequest { }
    public class CategoryDto { }
    public class CreateEnrolmentRequest { }
    public class UpdateEnrolmentStatusRequest { }
    public class EnrolmentDto { }
    public class CreateResultRequest { }
    public class ResultDto { }
}