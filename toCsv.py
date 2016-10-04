import sys, json

arr = json.load(sys.stdin)
firstLine = 0
for line in arr:
	props = line["event"]
	if firstLine == 0:
		header = "timestamp"
		for key in props.keys():
			header += ",%s" % key
		firstLine = 1
		print header

	lineStr = "%s" % line["timestamp"]
	for v in props.values():
		lineStr += ",%s" % v
	print lineStr
