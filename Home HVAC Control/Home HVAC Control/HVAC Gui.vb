' Owen Fujii
' RCET 3372
' 11/16/2024
' Smart Home Controller
Option Strict On
Option Explicit On
Option Compare Binary

'TODO
'{} Create GUI with toolstrip for serial setup
'{} Display active time on GUI 
'{} Display Temperature with state of cooling, heat, and fan
'{} Allow user to adjust 0.5 degree increments in a high and low setpoint boxes 
'{} Only allow room temperature to be applied from 50 to 90 degrees farenheit
'{} Analog Input 1 as the overall temperature of from
'{} Analog Input 2 as the temperature of the heating and cooling system
'{} Poll heating and cooling temperature every 2 min
'{} Thermal protection that shutsdown unit if temperature does not perform as desired
'{} Digital Input 1 handles safety interlock // low = error // Display error on GUI
'{} Display safety interlock error on Digital Output 1
'{} Digital Input 2 controls heating function
Public Class HVACGuiForm

    Public GrowlGreyLight As Color = Color.FromArgb(230, 213, 232)
    Public GrowlGreyMed As Color = Color.FromArgb(167, 167, 167)
    Public GrowlGrey As Color = Color.FromArgb(130, 130, 130)
    Public Roarange As Color = Color.FromArgb(244, 121, 32)
    Public RoarangeL As Color = Color.FromArgb(246, 146, 64)
    Public BengalBlack As Color = Color.FromArgb(0, 0, 0)



End Class
