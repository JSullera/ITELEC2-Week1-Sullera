
class Member
{
    public string MemberName { get; }
    public string MembershipType { get; }
    public bool IsActive { get; private set; }

    // Constructor
    public Member(string memberName, string membershipType)
    {
        MemberName = memberName;
        MembershipType = membershipType;
        IsActive = true;
    }

    // Method 1
    public bool RenewMembership()
    {
        if (!IsActive)
        {
            return false;
        }

        return true;
    }

    // Method 2
    public void ExpireMembership()
    {
        IsActive = false;
    }
}