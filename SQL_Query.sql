USE OrderFlowDb;
--SELECT * FROM dbo.Users;
--SELECT * FROM dbo.products;
--SELECT * FROM dbo.OrderItems;
--SELECT * FROM dbo.Orders;

--SELECT dbo.Users.Name, dbo.Orders.* FROM dbo.Users JOIN dbo.Orders ON dbo.Users.Id = dbo.Orders.UserId;

--SELECT _user.Name, SUM(_orderItems.Price * _orderItems.Quantity) as "Total", _orders.Status FROM dbo.Users as _user 
--	JOIN dbo.Orders as _orders
--	ON _user.Id = _orders.UserId
--		JOIN dbo.OrderItems as _orderItems 
--		ON _orders.Id = _orderItems.OrderId
--			GROUP BY _user.Name, _orders.Status;

SELECT DENSE_RANK() OVER (ORDER BY _orders.Id) AS "NumeroDaCompra", _orders.Id, _users.Name as "NameUser", _products.Name as "NameProduct", _products.Price, _orderItems.Quantity, _products.Stock, _orders.Status
FROM dbo.Users as _users
	JOIN dbo.Orders as _orders
	ON _users.Id = _orders.UserId
		JOIN dbo.OrderItems as _orderItems
		ON _orders.Id = _orderItems.OrderId
			JOIN dbo.Products as _products
			ON _products.Id = _orderItems.ProductId;