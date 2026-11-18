Member member1 = new Member("John Santos", "Monthly");
Member member2 = new Member("Maria Cruz", "Annual");

// Display first member
Console.WriteLine("=== PUMPortal Gym Membership ===");

Console.WriteLine("\nMember 1:");
Console.WriteLine("Name: " + member1.MemberName);
Console.WriteLine("Membership: " + member1.MembershipType);
Console.WriteLine("Active: " + member1.IsActive);

// Renew membership
Console.WriteLine("\nRenewing Member 1...");
Console.WriteLine("Renewal Successful: " + member1.RenewMembership());

// Expire membership
member1.ExpireMembership();

Console.WriteLine("\nMember 1 membership expired.");
Console.WriteLine("Active: " + member1.IsActive);

// Test rejected action
Console.WriteLine("\nTrying to renew expired membership...");
Console.WriteLine("Renewal Successful: " + member1.RenewMembership());

// Display second member
Console.WriteLine("\nMember 2:");
Console.WriteLine("Name: " + member2.MemberName);
Console.WriteLine("Membership: " + member2.MembershipType);
Console.WriteLine("Active: " + member2.IsActive);