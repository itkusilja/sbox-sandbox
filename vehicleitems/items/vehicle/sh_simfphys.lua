
ITEM.name = ""
ITEM.description = ""
ITEM.model = Model("")
ITEM.category = "Vehicle"
ITEM.width = 5
ITEM.height = 5

ITEM.functions.Place = {
	OnRun = function(itemTable)

		local client = itemTable.player
		local data = {}
			data.start = client:GetShootPos()
			data.endpos = data.start + client:GetAimVector() * 96
			data.filter = client
			
    local V = simfphys.SpawnVehicleSimple( "VEHICLECLASS", Vector(data.endpos), Angle(1,1,1) ) 
	
end}
