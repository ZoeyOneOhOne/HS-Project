select * from AspNetUsers;

select * from AspNetRoles;

select * from AspNetUserRoles;

select * from AspNetUsers a, AspNetUserRoles u, AspNetRoles r
where a.Id = u.UserId and u.UserId = r.Id;

/*insert into AspNetUserRoles values('8068b72b-4ed2-4daa-9930-a6acafdf8098', 1); */