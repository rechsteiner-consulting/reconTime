CREATE TABLE barcodeIN (
	barcodeinID int (20) NOT NULL AUTO_INCREMENT,
	lehrlingeIDFS smallint NOT NULL,
	barcode int (20) NOT NULL ,
	PRIMARY KEY (barcodeinID),
	foreign key (lehrlingeIDFS) references lehrlinge (LehrlingeID) on delete restrict on update cascade
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1;

CREATE TABLE barcodeOUT (
	barcodeoutID int (20) NOT NULL AUTO_INCREMENT,
	lehrlingeIDFS smallint NOT NULL,
	barcode int (20) NOT NULL ,
	PRIMARY KEY (barcodeoutID),
	foreign key (lehrlingeIDFS) references lehrlinge (LehrlingeID) on delete restrict on update cascade
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1;

