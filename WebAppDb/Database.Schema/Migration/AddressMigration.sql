MERGE INTO Address AS Target 
USING (VALUES 
  (0, N'Undefined'), 
  (1, N'Billing'), 
  (2, N'Home'), 
  (3, N'Main Office'), 
  (4, N'Primary'), 
  (5, N'Shipping'), 
  (6, N'Archive') 
) 
AS Source (ID, Name) 
ON Target.ID = Source.ID 

WHEN MATCHED THEN 
UPDATE SET Name = Source.Name 

WHEN NOT MATCHED BY TARGET THEN 
INSERT (ID, Name) 
VALUES (ID, Name) 

WHEN NOT MATCHED BY SOURCE THEN 
DELETE;