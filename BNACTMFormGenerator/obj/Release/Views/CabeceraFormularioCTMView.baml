   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  N JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BNACTMFormGenerator.VMLBNACTMFormGenerator.VML 9   3BNACTMFormGenerator.Views.CabeceraFormularioCTMView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9System&clr-namespace:System;assembly=mscorlib     5vml%clr-namespace:BNACTMFormGenerator.VML     .  (BNACTMFormGenerator.VML.ViewModelLocator    AutoHookedUpViewModel  . $	��359��$	��350�� � 	Resources  �� MergedDictionaries �� Source��  �� $! ..\MainWindowResources.xaml?�%    .��� $��0,0,0,0q� +� FocusedElement ��  �� ElementName$ ControlConFoco�� � ColumnDefinitions �� $
��Auto ��� $��* � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��80 ��� $
��Auto ��� $
��Auto �.+��� $��0��$��0��$��2��$��4q�$1��+Datos de cabecera para el Formulario de CTM��$��Center=�$
��Bold"��� $��0��$��1��$��4q�$��Fecha:��$��Right=�(  "System.Windows.Controls.DatePicker  $��1��$��1��$	��200��   Text �� *Fecha+	 �� Mode$	 TwoWay=�
 �� ValidatesOnDataErrors
 .  �� NotifyOnValidationError . �� $��0��$��2��$��4q�$��Nombre del Procedimiento:��$��Right=��� -   $��ControlConFoco��$��1��$��2��$��21��$	��200�� '  #ToolTipWithErrorMessageOnErrorStyle#��[  ���� *NombreProcedimiento+$	 TwoWay=�
 .  . �� $��0��$��3��$��4q�$��Usuario:��$��Right=��� $��1��$��3��$��21��$	��200��#��[  ���� *	Usuario+$	 TwoWay=�
 .  . �� $��0��$��4��$��4q�$��Area:��$��Right=��� $��1��$��4��$��21��$	��200��#��[  ���� *Area+$	 TwoWay=�
 .  . �� $��0��$��5��$��4q�$��Descripción:��$��Right=��� $��1��$��5��$��21��$	��200��#��[  ���� *Descr+$	 TwoWay=�
 .  . �� $��0��$��6��$��4q�$��Periodicidad:��$��Right=��� $��1��$��6��$	��200��$��21�� / +ComboBoxToolTipWithErrorMessageOnErrorStyle#��[ ����   dataFromEnum �� Source# [  �� SelectedValue ��  �� Path$ Periodicidad� �� UpdateSourceTrigger$ PropertyChanged=�$	 TwoWay=�
 .  . �� $��0��$��7��$��4q�$!��Detalle de la periodicidad:��$��Right=��� $��1��$��7��$��75��$	��200�� �� AcceptsReturn . #��[  ���� *DetalleFrecuencia+$	 TwoWay=�
 .  . �� $��0��$��8��$ ��Hora de Inicio ejecución:��$��Right=��� $��1��$��8�� �� Orientation$ 
Horizontal=�$��2,0,0,0q�.+���   
HorasArray#��[ $��20��$��40��$	��Top=�$��Right=�#��[  �� SelectedIndex �� *HoraInicioEjecucion+�� $	�� : ��$��12(�$��25��$��10��$	��Top=�$��Right=���   MinutosArray#��[ $��20��$��40��$	��Top=�$��Right=�#��[  �� *MinutosInicioEjecucion+�� $��0��$��9��$$��Hora Limite Inicio ejecución:��$
��Left=��� $��1��$��9��$ 
Horizontal=�$��2,0,0,0q�.+��� #��[ $��20��$��40��$	��Top=�$��Right=� �� *HoraLimiteInicioEjecucion+�� $	�� : ��$��12(�$��25��$��10��$	��Top=�$��Right=��� #��[ $��20��$��40��$	��Top=�$��Right=� �� *MinutosLimiteInicioEjecucion+