
import time
import Adafruit_DHT as dht
import MySQLdb
mydb = MySQLdb.connect("remotemysql.com","MxOJ0NTKIO","7QwUSwSfbA","MxOJ0NTKIO")
mycursor = mydb.cursor()
sql = "INSERT INTO current (temperature, humidity) VALUES (%s, %s)"
while True:
	hum, temp = dht.read_retry(dht.DHT22,4)
	val = (temp, hum)
	mycursor.execute(sql, val)
	mydb.commit()
	time.sleep(300)
