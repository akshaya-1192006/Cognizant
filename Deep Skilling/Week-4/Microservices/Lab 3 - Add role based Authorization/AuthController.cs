var claims = new[]
{
    new Claim(ClaimTypes.Name, model.Username),
    new Claim(ClaimTypes.Role, "Admin")
};
