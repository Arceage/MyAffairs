   M S B A M L   `   `   `  ����D  @MyAffairs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MyAffairs	MyAffairs  5   	       MyAffairs.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MyAffairs     5   	   -   5          � Title$  MA��5   	   $	��450��6   $	��800��6!   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 dgMA��5
      $��16(�6!      AutoGenerateColumns .  $
��Bold"�6K      GridLinesVisibility$	 All=�6]    J� Opacity$	 0.9Q�6w      HorizontalGridLinesBrush �	#FFC1ADAD   VerticalGridLinesBrush �	#FFC1ADAD���	#FFDBDCD9   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly . 	   Header$	 CreationDate��6^   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 195 6t      
Foreground �	#FF809155   
FontFamily$ Segoe UI Semibold)�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6&   ��  �� Path$ 
CreateTime�6�   4  .System.Windows.Controls.DataGridCheckBoxColumn  5       .  $	 	Completed��6�   $
 93 6�    6*   �� $ IsCompleted� �� UpdateSourceTrigger$ PropertyChanged=�6�     5         
FontWeight$ DemiBold"�6%    .  $	 Affairs��6p   $
 * 6�   $ Yu Gothic UI Semibold)�6�    6;   �� $ MyTask�6�   5      5      5      