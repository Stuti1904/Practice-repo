/*JSON_VALUE VS JSON_QUERY*/

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

SET @Skills = JSON_QUERY(@JSONObject, '$.info.tags' ) /*RETURNS AN ARRAY OR OBJECT*/

SELECT @Skills

SELECT JSON_VALUE(@JSONObject,'$.info.tags[0]')/*WE NEED TO SPECIFY THE EXACT FIELD WE WANT AND WILL RETURN A SCALAR SINGLE VALUE*/

