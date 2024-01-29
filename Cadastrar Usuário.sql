Insert Into ApplicationUser (NomeCompleto, RG, CPF, RoleId, UserName, NormalizedUserName, Email, NormalizedEmail,
EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled,
LockoutEnd, LockoutEnabled, AccessFailedCount)
					Values ('Gustavo da Silva Oliveira', '28.911.393-3', '325.305.570-12', 1, 
'gsoey2019123@gmail.com', 'GSOEY2019123@GMAIL.COM', 'gsoey2019123@gmail.com', 
'GSOEY2019123@GMAIL.COM', 1, 'AQAAAAIAAYagAAAAEJv7GM3eptyplFgbB6RrpHkGZzX6gJVQVQeysqbCV2bUu11yNgT+9JyuwC8NoCbBsg==',
'GKXME4PYILIE6DQRTF6ZPR5VAC3OXCPD', '1026fcad-07e8-4d37-894f-c65477dd1d55', '+55 (11) 98174-6450', 1, 0, null, 0, 0)

Insert Into Roles ([Name], NormalizedName, ConcurrencyStamp)
		Values ('Administrador', 'ADMINISTRADOR', '2e9cfff6-2902-4fe2-8267-63fcee9ead19'),
			   ('Cliente', 'Cliente', 'a72ebeea-f57b-4873-82a2-a129b66ddaa9')

Insert Into UserRoles (UserId, RoleId)
			Values (1, 1)

Select * From ApplicationUser

Select * From Roles

Select * From UserRoles