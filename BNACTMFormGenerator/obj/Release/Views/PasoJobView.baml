   M S B A M L   `   `   `  ���� N  JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BNACTMFormGenerator.ViewModelBNACTMFormGenerator.ViewModel  +    %BNACTMFormGenerator.Views.PasoJobView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     :vm+clr-namespace:BNACTMFormGenerator.ViewModel       � 	Resources   �� MergedDictionaries �� Source��  �� $! ..\MainWindowResources.xaml?�%    .���  � ColumnDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $	��110 �.+��� $��0��$��0��$��	PASO N° ��$��Right=�$
��Bold"�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFE0E7EA�� � Offset$ 0Q�� $ 	#FF7DD0F5��$ 1Q��� $��1��$��0��$
��Left=�$
��Bold"����� *	NroPaso+.������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFE0E7EA��$ 0Q�� $ 	#FF7DD0F5��$ 1Q�.���� $��0��$��1��$��Servidor Test:���� $��1��$��1��$
��Left=�$	��400��$��21��$	��Top=� '  #ToolTipWithErrorMessageOnErrorStyle#��[  ���� *ServidorTest+	 �� Mode$	 TwoWay=�
 �� ValidatesOnDataErrors
 .  �� NotifyOnValidationError . �� $��0��$��2��$��Servidor Prod:���� $��1��$��2��$
��Left=�$	��400��$��21��$	��Top=�#��[  ���� *ServidorProd+$	 TwoWay=�
 .  . �� $��0��$��3��$��Nombre Job CTM Test:���� $��1��$��3��$
��Left=�$	��200��$��21��$	��Top=�#��[  ���� *NombreJobCTMTest+$	 TwoWay=�
 .  . �� $��0��$��4��$	��133��$��Nombre Job CTM Prod:���� $��1��$��4��$
��Left=�$	��200��$��21��$	��Top=�#��[  ���� *NombreJobCTMProd+$	 TwoWay=�
 .  . �� $��0��$��5��$��Parametros:���� $��1��$��5������ *
NewParam+$	 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $��1��$��6��$	��100������ *
Parametros+ �� SelectedItem �� *SelectedParam+�� $��2��$��5��$��Agregar��$��20������ *
AddParam+�� $��3��$��5��$��Eliminar��$��20������ *
DelParam+