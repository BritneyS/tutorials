----tutorial-sql-4.sql

SELECT * 
FROM orders
LIMIT 5;

SELECT *
FROM subscriptions
LIMIT 5;

SELECT *
FROM customers
LIMIT 5;

------

Sports Magazine
Joe Schmo

SELECT description
FROM subscriptions;

-----

SELECT *
FROM orders
JOIN subscriptions
ON orders.subscription_id = subscriptions.subscription_id;

SELECT *
FROM orders
JOIN subscriptions
ON orders.subscription_id = subscriptions.subscription_id
WHERE subscriptions.description = 'Fashion Magazine';

-----

SELECT COUNT(*)
FROM newspaper;

SELECT COUNT(*)
FROM online;

SELECT COUNT(*)
FROM newspaper
JOIN online
	ON newspaper.id = online.id;

-------

SELECT *
FROM newspaper
LEFT JOIN online
	ON newspaper.id = online.id;

SELECT *
FROM newspaper
LEFT JOIN online
	ON newspaper.id = online.id
WHERE online.id IS NULL;

-----

SELECT *
FROM classes
JOIN students
	ON classes.id = students.class_id;

-----

SELECT COUNT(*)
FROM newspaper
WHERE start_month < 3 AND end_month > 3;

SELECT *
FROM newspaper
CROSS JOIN months;

SELECT *
FROM newspaper
CROSS JOIN months
WHERE month > start_month AND month < end_month;

SELECT month,
  COUNT(*) as subscribers
FROM newspaper
CROSS JOIN months
WHERE month > start_month 
	AND month < end_month
GROUP BY month;

-----

SELECT *
FROM newspaper
UNION
SELECT *
FROM online;

-------

WITH previous_query AS (
	SELECT customer_id,
   COUNT(subscription_id) as subscriptions
FROM orders
GROUP BY customer_id
)
SELECT customers.customer_name, previous_query.subscriptions
FROM previous_query
JOIN customers
ON previous_query.customer_id = customers.customer_id;








