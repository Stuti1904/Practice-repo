WITH PARTS(PRODUCTASSEMBLYID, COMPONENTID, PERASSEMBLYQTY,ENDDATE, COMPONENTLEVEL)AS
(
SELECT b.ProductAssemblyID, b.ComponentID, b.PerAssemblyQty, b.EndDate, 0 AS ComponentLevel
FROM Production.BillOfMaterials AS b
WHERE b.ProductAssemblyID= 800
AND b.EndDate IS NULL
UNION ALL
SELECT bom.ProductAssemblyID, bom.ComponentID, p.PerAssemblyQty,
		bom.EndDate, ComponentLevel+1
		FROM Production.BillOfMaterials AS bom
		INNER JOIN Parts AS p
		ON bom.ProductAssemblyID= p.COMPONENTID
		and bom.EndDate is null
		)
		update Production.BillOfMaterials
		set PerAssemblyQty= c.PerAssemblyQty*2
		FROM Production.BillOfMaterials AS c
		JOIN Parts AS d ON c.ProductAssemblyID=d.PRODUCTASSEMBLYID
		where d.COMPONENTLEVEL=0;
