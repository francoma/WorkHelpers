   M S B A M L   `   `   `  ����   BNACTMFormGenerator8    2BNACTMFormGenerator.Views.TransferenciaArchivoView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     $	��537��  � 	Resources   �� MergedDictionaries �� Source��  �� $! ..\MainWindowResources.xaml?�%    .���  � ColumnDefinitions �� $	��130 ��� $	��200 ��� $	��200 � � RowDefinitions �� �� �� �� �� �� �� �� �� .+��� $��0��$��0��$��Tipo de Origen: ��$	��130���� $��1��$��0��$��21�� �� SelectedIndex$ 2������    EnumTipoOrigen �� Source# [   �� SelectedItem ��  �� Path$ OrigenArchivos��� $
��TEST��$��1��$��1��$
��Bold"�$��Center=�	 �� TextAlignment$	 Center=����	#FF57CDBD�� $
��PROD��$��2��$��1��$
��Bold"�$��Center=�$	 Center=����	#FF57CDFF�� $��0��$��2��$��
Servidor: ��$	��130���� $��1��$��2��$
��Left=�$	��200��$��21��$	��Top=� ' #ToolTipWithErrorMessageOnErrorStyle#��[ ���� *ServidorTest+
 �� Mode$
 TwoWay=� �� ValidatesOnDataErrors .  �� NotifyOnValidationError . �� $��2��$��2��$
��Left=�$	��200��$��21��$	��Top=�#��[ ���� *ServidorProd+$
 TwoWay=� .  . �� $��0��$��3��$��Ruta: ��$	��130���� $��1��$��3��$
��Left=�$	��200��$��21��$	��Top=�#��[ ���� *
RutaTest+$
 TwoWay=� .  . �� $��2��$��3��$
��Left=�$	��200��$��21��$	��Top=�#��[ ���� *
RutaProd+$
 TwoWay=� .  . �� $��0��$��4��$��
Archivos: ��$	��130���� $��1��$��4��$
��Left=�$	��200��$��21��$	��Top=�#��[ ���� *ArchivoTest+$
 TwoWay=� .  . �� $��2��$��4��$
��Left=�$	��200��$��21��$	��Top=�#��[ ���� *ArchivoProd+$
 TwoWay=� .  . �� $��0��$��5��$��FILE__OPTION:��$	��130���� $��1��$��5��$
��Left=�$	��200��$��21��$	��Top=� �� SelectedValuePath$ Content�� / +ComboBoxToolTipWithErrorMessageOnErrorStyle#��[  �� SelectedValue �� *FileOptionTest+$
 TwoWay=� .  .  �� UpdateSourceTrigger$ PropertyChanged=�.@��� .��	REPLACE�� .��CREATE�� $��2��$��5��$
��Left=�$	��200��$��21��$	��Top=�$ Content��#��[  �� *FileOptionProd+$
 TwoWay=� .  . $ PropertyChanged=�.@��� .��	REPLACE�� .��CREATE�� $��0��$��6��$��RECORD__FORMAT:��$	��130���� $��1��$��6��$
��Left=�$��50��$��21��$	��Top=�#��[ ���� *RecordFormatTest+$
 TwoWay=� .  . �� $��2��$��6��$
��Left=�$��50��$��21��$	��Top=�#��[ ���� *RecordFormatProd+$
 TwoWay=� .  . �� $��0��$��7��$��LRECL:��$	��130���� $��1��$��7��$
��Left=�$��50��$��21��$	��Top=�#��[ ���� *	LReclTest+$
 TwoWay=� .  . �� $��2��$��7��$
��Left=�$��50��$��21��$	��Top=�#��[ ���� *	LReclProd+$
 TwoWay=� .  . �� $��0��$��8��$��BLKSIZE:��$	��130���� $��1��$��8��$
��Left=�$��50��$��21��$	��Top=�#��[ ���� *BlkSizeTest+$
 TwoWay=� .  . �� $��2��$��8��$
��Left=�$��50��$��21��$	��Top=�#��[ ���� *BlkSizeProd+$
 TwoWay=� .  . 