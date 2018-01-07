EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all";
DROP TABLE __MigrationHistory
DROP TABLE Hotels
DROP TABLE Pictures
DROP TABLE ReservationRooms
DROP TABLE Reservations
DROP TABLE Rooms