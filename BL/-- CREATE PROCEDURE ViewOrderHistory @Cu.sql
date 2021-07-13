-- CREATE PROCEDURE ViewOrderHistory @CustomerId int
-- AS 
-- SELECT  Customers.CustId, Orders.OrderId, Stores.StoreId, Stores.StoreName, LineItems.LineItemsId, LineItems.ItemId, LineItems.Quantity, LineItems.Price 
-- FROM Customers
-- INNER JOIN Orders ON Customers.CustId = Orders.CustId
-- INNER JOIN LineItems ON Orders.OrderId = LineItems.OrderId
-- INNER JOIN Stores ON Orders.StoreId = Stores.StoreId 
-- WHERE Customers.CustId = @CustomerId

