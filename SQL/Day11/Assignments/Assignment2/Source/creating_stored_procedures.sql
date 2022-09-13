/*CREATING A STORED PROCEDURE*/

CREATE PROCEDURE UPDATEMARKS
AS
BEGIN
SET NOCOUNT ON
DECLARE @sc_weight_cbsc FLOAT, @math_weight_cbsc FLOAT, @eng_weight_cbsc FLOAT, @sc_weight_state FLOAT, @math_weight_state FLOAT, @eng_weight_state FLOAT
  SET   @sc_weight_cbsc  = 0.50
       SET @math_weight_cbsc  = 0.40
         SET @eng_weight_cbsc  = 0.10
     SET   @sc_weight_state  = 0.40
        SET @math_weight_state  = 0.40
       SET  @eng_weight_state = 0.20
	   UPDATE M
    SET M.Average = 
    IIF(S.Board = 'State', (M.Science * @sc_weight_state) + (M.Math * @math_weight_state) + (M.English * @eng_weight_state), (M.Science * @sc_weight_cbsc) + (M.Math * @math_weight_cbsc) + (M.English * @eng_weight_cbsc))    
    FROM MARKS M JOIN STUDENT S
    ON M.StudentID = S.StudentID
    UPDATE M
    SET M.Grade = 
    IIF(S.Board = 'State',
    CASE 
        WHEN M.Average >= 80 THEN 'A+'
        WHEN M.Average >= 60 THEN 'A'
        WHEN M.Average >= 50 THEN 'B'
        WHEN M.Average >= 35 THEN 'C'
        WHEN M.Average < 35 THEN 'D'
        ELSE 'AVERAGE IS UNDER 30'
    END, 
    CASE 
        WHEN M.Average >= 95 THEN 'A+'
        WHEN M.Average >= 85 THEN 'A'
        WHEN M.Average >= 75 THEN 'B'
        WHEN M.Average > 50 THEN 'C'
        WHEN M.Average < 50 THEN 'D'
        ELSE 'AVERAGE IS UNDER 40'
    END
    )
    FROM MARKS M JOIN STUDENT S
    ON M.StudentID = S.StudentID

END
GO

EXEC UPDATEMARKS
 


