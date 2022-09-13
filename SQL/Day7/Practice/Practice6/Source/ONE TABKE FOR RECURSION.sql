/*USE ONE TABLE FOR RECUSRION*/

WITH PARTS(ProductAssemblyID, ComponentID, PerAssemblyQty, EndDate, ComponentLevel) AS
(
	SELECT B.ProductAssemblyID, B.ComponentID, B.PerAssemblyQty,
		B.EndDate, 0 AS ComponentLevel 
		FROM Production.BillOfMaterials AS b
		WHERE b.ProductAssemblyID=800
		AND b.EndDate IS NULL
		UNION ALL
		SELECT bom.ProductAssemblyID, bom.ComponentID, p.PerAssemblyQty,
			bom.EndDate, ComponentLevel+1
			FROM Production.BillOfMaterials AS bom
			INNER JOIN PARTS AS p
			ON bom.ProductAssemblyID= p.ComponentID
			AND bom.EndDate IS NULL
			)
			SELECT ProductAssemblyID, ComponentID, Name, EndDate,ComponentLevel
			FROM PARTS AS p
			INNER JOIN Production.Product AS pr
			ON p.ComponentID=pr.ProductID
			ORDER BY ComponentLevel,ProductAssemblyID, ComponentID