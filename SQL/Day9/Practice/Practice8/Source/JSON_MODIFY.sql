/*JSON_MODIFY*/

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

SELECT JSON_VALUE(@JSONObject,'$.info.address.town')

SET @JSONObject = JSON_MODIFY(@JSONObject, '$.info.address.county','Worcestershire')

SELECT JSON_VALUE(@JSONObject,'$.info.address.county')