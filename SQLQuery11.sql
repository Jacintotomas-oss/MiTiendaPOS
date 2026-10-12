SELECT v.Id, v.Fecha, c.Nombre AS Cliente, u.NombreUsuario AS Usuario, v.Total
FROM Ventas v
JOIN Clientes c ON c.Id = v.ClienteId
JOIN Usuarios u ON u.Id = v.UsuarioId;

SELECT d.VentaId, p.Nombre, d.Cantidad, d.PrecioUnitario, d.Subtotal
FROM DetallesVenta d
JOIN Productos p ON p.Id = d.ProductoId;

SELECT Id, Nombre, Stock FROM Productos WHERE Id IN (1, 3, 7);