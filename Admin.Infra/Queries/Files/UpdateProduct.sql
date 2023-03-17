UPDATE Products
SET Name = iif(@Name is not null, @Name, Name), 
    Description = iif(@Description is not null, @Description, Description), 
    Price = iif(@Price is not null, @Price, Price)
WHERE Id = @Id; 