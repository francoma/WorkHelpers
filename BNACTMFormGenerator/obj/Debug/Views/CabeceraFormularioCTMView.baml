   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      N JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BNACTMFormGenerator.VMLBNACTMFormGenerator.VML 5      9   3BNACTMFormGenerator.Views.CabeceraFormularioCTMView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9System&clr-namespace:System;assembly=mscorlib     5      5vml%clr-namespace:BNACTMFormGenerator.VML     5      .  (BNACTMFormGenerator.VML.ViewModelLocator    AutoHookedUpViewModel  . $	��359��5	      $	��350��6+    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $! ..\MainWindowResources.xaml?�6%   %    5      .��5      � $��0,0,0,0q�6    +� FocusedElement 6   ��  �� ElementName$ ControlConFoco�� � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $��80 �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   .+�5%   
   �� $��0��6   $��0��6$   $��2��61   $��4q�6E   $1��+Datos de cabecera para el Formulario de CTM��6P   $��Center=�6�   $
��Bold"�6�   �� 5'   
   $��0��6   $��1��6    $��4q�6-   $��Fecha:��68   $��Right=�6I   (  "System.Windows.Controls.DatePicker  5(   
   $��1��6   $��1��5)      $	��200��5+         Text 5*      �� *Fecha+	 �� Mode$	 TwoWay=�
 �� ValidatesOnDataErrors
 .  �� NotifyOnValidationError . 5+      �� 5-   
   $��0��6   $��2��6    $��4q�6-   $��Nombre del Procedimiento:��68   $��Right=�6\   �� 5.   
   -   5        $��ControlConFoco��5.      $��1��5/      $��2��50      $��21��52      $	��200��53       '  #ToolTipWithErrorMessageOnErrorStyle#��[  54      ��51      �� *NombreProcedimiento+$	 TwoWay=�
 .  . 54      �� 56   
   $��0��6   $��3��6    $��4q�6-   $��Usuario:��68   $��Right=�6K   �� 57   
   $��1��6   $��3��58      $��21��59      $	��200��5;      #��[  5<      ��5:      �� *	Usuario+$	 TwoWay=�
 .  . 5<      �� 5>   
   $��0��6   $��4��6    $��4q�6-   $��Area:��68   $��Right=�6H   �� 5?   
   $��1��6   $��4��5@      $��21��5A      $	��200��5C      #��[  5D      ��5B      �� *Area+$	 TwoWay=�
 .  . 5D      �� 5F   
   $��0��6   $��5��6    $��4q�6-   $��Descripción:��68   $��Right=�6O   �� 5G   
   $��1��6   $��5��5H      $��21��5I      $	��200��5K      #��[  5L      ��5J      �� *Descr+$	 TwoWay=�
 .  . 5L      �� 5N   
   $��0��6   $��6��6    $��4q�6-   $��Periodicidad:��68   $��Right=�6P   �� 5O   
   $��1��6   $��6��5P      $	��200��5S      $��21��5T       / +ComboBoxToolTipWithErrorMessageOnErrorStyle#��[ 5U      ��5Q      ��   dataFromEnum �� Source# [  �� SelectedValue 5R      ��  �� Path$ Periodicidad� �� UpdateSourceTrigger$ PropertyChanged=�$	 TwoWay=�
 .  . 5U      �� 5W   
   $��0��6   $��7��6    $��4q�6-   $!��Detalle de la periodicidad:��68   $��Right=�6^   �� 5X   
   $��1��6   $��7��5Y      $��75��5Z      $	��200��5\       �� AcceptsReturn . #��[  5^      ��5[      �� *DetalleFrecuencia+$	 TwoWay=�
 .  . 5^      �� 5a   
   $��0��6   $��8��6!   $ ��Hora de Inicio ejecución:��6.   $��Right=�6R   �� 5b   
   $��1��6   $��8��6&    �� Orientation$ 
Horizontal=�64   $��2,0,0,0q�6M   .+�5c      ��   
HorasArray#��[ 5d      $��20��5e      $��40��5f      $	��Top=�5g      $��Right=�5h      #��[ 5i       �� SelectedIndex 5c      �� *HoraInicioEjecucion+5i      �� 5j      $	�� : ��6   $��12(�6#   $��25��61   $��10��6=   $	��Top=�6H   $��Right=�6`   �� 5k        MinutosArray#��[ 5l      $��20��5m      $��40��5n      $	��Top=�5o      $��Right=�5p      #��[ 5q       5k      �� *MinutosInicioEjecucion+5q      5r      �� 5u   
   $��0��6   $��9��6!   $$��Hora Limite Inicio ejecución:��6.   $
��Left=�6V   �� 5v   
   $��1��6   $��9��6&   $ 
Horizontal=�64   $��2,0,0,0q�6M   .+�5w      �� #��[ 5x      $��20��5y      $��40��5z      $	��Top=�5{      $��Right=�5|       5w      �� *HoraLimiteInicioEjecucion+5|      �� 5}      $	�� : ��6   $��12(�6#   $��25��61   $��10��6=   $	��Top=�6H   $��Right=�6`   �� 5~      #��[ 5      $��20��5�      $��40��5�      $	��Top=�5�      $��Right=�5�       5~      �� *MinutosLimiteInicioEjecucion+5�      5�      5�      5�      