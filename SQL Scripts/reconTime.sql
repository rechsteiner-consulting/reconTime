CREATE TABLE Lehrlinge (
	lehrlingeID smallint NOT NULL AUTO_INCREMENT,
	name varchar (25) NOT NULL,
	prename varchar (25) NOT NULL,
	PRIMARY KEY (LehrlingeID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1;

CREATE TABLE Arbeitszeiten (
	arbeitszeitenID int (20) NOT NULL AUTO_INCREMENT,
	lehrlingeIDFS smallint NOT NULL,
	startTime date,
	endTime date,
	timeDiff time,
	PRIMARY KEY (arbeitszeitenID),
	KEY lehrlingeIDFS (lehrlingeIDFS)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1;

