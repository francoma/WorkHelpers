   M S B A M L   `   `   `  ����   BNACTMFormGenerator*    $BNACTMFormGenerator.Views.PasoSHView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       � 	Resources   �� MergedDictionaries �� Source��  �� $! ..\MainWindowResources.xaml?�%    .���  � ColumnDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $	��110 �.+��� $��0��$��0��$��	PASO N° ��$��Right=�$
��Bold"�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFE0E7EA�� � Offset$ 0Q�� $ 	#FF7DD0F5��$ 1Q��� $��1��$��0��$
��Left=�$
��Bold"����� *	NroPaso+.������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFE0E7EA��$ 0Q�� $ 	#FF7DD0F5��$ 1Q�.���� $��0��$��1��$��Tipo Sh:���� $��1��$��1��$��21��$	��100��$
��Left=�	 �� SelectedIndex$	 0������    TiposSh
 �� Source#
 [   �� SelectedItem ��  �� Path$ CurrentTipoSh��� $��0��$��2��$��Servidor Test:���� $��1��$��2��$
��Left=�$	��400��$��21��$	��Top=� ' #ToolTipWithErrorMessageOnErrorStyle#��[ ���� *ServidorTest+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� NotifyOnValidationError . �� $��0��$��3��$��Servidor Prod:���� $��1��$��3��$
��Left=�$	��400��$��21��$	��Top=�#��[ ���� *ServidorProd+$ TwoWay=� .  . �� $��0��$��4��$��Base de Datos Test:���� $��1��$��4��$
��Left=�$	��200��$��21��$	��Top=�#��[ ���� *BaseDatosTest+$ TwoWay=� .  . �� $��0��$��5��$��Base de Datos Prod:���� $��1��$��5��$
��Left=�$	��200��$��21��$	��Top=�#��[ ���� *BaseDatosProd+$ TwoWay=� .  . �� $��0��$��6��$!��Usuario de Ejecución Test:���� $��1��$��6��$
��Left=�$	��200��$��21��$	��Top=�#��[ ���� *UsuarioEjecucionTest+$ TwoWay=� .  . �� $��0��$��7��$!��Usuario de Ejecución Prod:���� $��1��$��7��$��21��$	��Top=�#��[ ���� *UsuarioEjecucionProd+$ TwoWay=� .  . �� $��0��$��8��$��Ubicación Sh en Test:���� $��1��$��8��$
��Left=�$	��200��$��21��$	��Top=�#��[ ���� *UbicacionScriptTest+$ TwoWay=� .  . �� $��0��$��9��$��Ubicación Sh en Prod:���� $��1��$��9��$��21��$	��Top=�#��[ ���� *UbicacionScriptProd+$ TwoWay=� .  . �� $��0��$��10��$��
Script Sh:���� $��1��$��10��$��21��$	��Top=�#��[ ���� *Script+$ TwoWay=� .  . �� $��0��$��11��$��Parametros:���� $��1��$��11��$��21������ *
NewParam+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $��1��$��12��$	��100������ *
Parametros+ �� *SelectedParam+�� $��2��$��11��$��Agregar��$��20������ *
AddParam+�� $��3��$��11��$��Eliminar��$��20������ *
DelParam+