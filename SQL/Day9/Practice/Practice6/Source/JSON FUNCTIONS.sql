SELECT 'Text' as myText,  
   (SELECT 12 day, 8 mon FOR JSON PATH, WITHOUT_ARRAY_WRAPPER) as myJson  
FOR JSON PATH /* WITHOUT ARRAY WRAPPERS*/


/*JSON_VALUE*/

DECLARE @JSONObject varchar(max)
SET @JSONObject = '{
   "info": {
      "type": 1,
      "address": {
         "town": "Cheltenham",
         "county": "Gloucestershire",
         "country": "England"
      },
      "tags": ["Sport", "Water polo"]
   },
   "type": "Basic"
} '
DECLARE @Skills varchar(MAX)

SET @Skills = JSON_QUERY(@JSONObject, '$.info.tags' )

SELECT @Skills

SELECT JSON_VALUE(@JSONObject,'$.info.tags[0]')