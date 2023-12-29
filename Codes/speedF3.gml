 if (global.target_speed >= 80)  
{  
    global.target_speed -= 40  
    scr_actionsLogUpdate((string((global.target_speed / 40)) + "x Speed"))  
    alarm[7] = 1  
}  
else  
    scr_actionsLogUpdate("Can't reduce speed below 1x.")