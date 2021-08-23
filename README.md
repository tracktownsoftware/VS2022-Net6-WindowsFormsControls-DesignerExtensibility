# VS2022-Net6-WindowsFormsControls-DesignerExtensibility
Figuring out VS2022 toolbox and designer extensibility support for custom Net6 WinForms controls in VS2022

### Folder VS2019_DN4pt6WinFormControl contains a .Net Framework 4.6 example of a Windows Forms custom MyButton control with designer extensibility in Visual Studio 2019. 
This is included here as an example of what I want to do with a Net6 Windows Forms custom control in Visual Studio 2022 (Automatically add control to Visual Studio toolbox and support design-time behavior).

Steps to see VS2019_DN4pt6WinFormControl example:
1. Open VS2019_DN4pt6WinFormControl.sln in Visual Studio 2019
2. Build release configuration
3. From the solution folder run copyBinToTempFolder.bat (or copy files by hand) to copy bin output to the paths below:
    - C:\temp\NetFrameworkWinFormControl\bin\NetFrameworkWinFormControl.dll
    - C:\temp\NetFrameworkWinFormControl\bin\design\NetFrameworkWinFormControl.Design.dll
4. Run RegistryEntriesForVS2019IDE.reg to add registry entries that:
    - Automatically load MyButton control into the VS2019 Toolbox for Windows Forms projects
    - Inform VS2019 that NetFrameworkWinFormControl.Design.dll is in the Design subfolder.
6. In VS2019 make a new .Net Framework Windows Forms project. 
7. Open the Form1 design surface.
8. Open the VS2019 Toolbox. Observe that the MyButton control is in the VS toolbox (thanks to the toolbox registry entry in step 4).
9. Click MyButton in the toolbox and then click+drag on Form1 design surface to draw MyButton control
10. Rt-click MyButton control on Form1 design surface to use functional design-time context menu items (image below)

![Image](VS2019_DN4pt6WinFormControl/VS2019_MyButtonDesignTime.png)
