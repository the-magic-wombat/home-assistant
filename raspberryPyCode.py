Python 3.5.3 (default, Sep 27 2018, 17:25:39) 
[GCC 6.3.0 20170516] on linux
Type "copyright", "credits" or "license()" for more information.
>>> import time
>>> import Adafruit_DHT as dht
>>> import MySQLdb
>>> mydb = MySQLdb.connect("remotemysql.com","MxOJ0NTKIO","7QwUSwSfbA","MxOJ0NTKIO")
>>> mycursor = mydb.cursor()
>>> sql = "INSERT INTO current (temperature, humidity) VALUES (%s, %s)"
>>> while True:
	hum, temp = dht.read_retry(dht.DHT22,4)
	val = (temp, hum)
	mycursor.execute(sql, val)
	mydb.commit()
	time.sleep(300)
